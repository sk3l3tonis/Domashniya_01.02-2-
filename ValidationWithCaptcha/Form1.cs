using Npgsql;
using System.Data;
using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;


namespace ValidationWithCaptcha
{
    public partial class Form1 : Form
    {
        private int attempts = 0;
        private string connectionString = "Host=localhost; Port=5432; Database=auth2; Username=postgres; Password=1212321";
        private string expectedCaptcha = "";
        private Timer captchaTimer;

        private bool ValidateCredentials(string username, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM userss WHERE username = @username AND password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private string GenerateCaptcha()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string captcha = "";
            for (int i = 0; i < 6; i++)
            {
                captcha += chars[random.Next(chars.Length)];
            }
            return captcha;
        }

         private Bitmap GenerateCaptchaImage(string captchaText)
        {
            Bitmap image = new Bitmap(captchaLabel.Width, captchaLabel.Height);
            using (Graphics graphics = Graphics.FromImage(image))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, image.Width, image.Height),
                Color.LightGray, Color.White, 90f))
            {
                graphics.FillRectangle(brush, 0, 0, image.Width, image.Height);

                using (Font font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Bold))
                using (Pen pen = new Pen(Color.Black, 2f))
                {
                    for (int i = 0; i < captchaText.Length; i++)
                    {
                        char c = captchaText[i];

                        int offsetX = new Random().Next(-2, 2);
                        int offsetY = new Random().Next(-2, 2);
                        float angle = new Random().Next(-5, 5) / 10f;

                        Matrix matrix = new Matrix();
                        matrix.Shear(angle, 0);
                        matrix.Rotate(angle);

                        graphics.Transform = matrix;

                        PointF position = new PointF(25 * i, 0);
                        graphics.DrawString(c.ToString(), font, Brushes.Black, position);

                        Point startPoint = new Point((int)(position.X + 5), (int)(position.Y + 10));
                        Point endPoint = new Point((int)(position.X + 20), (int)(position.Y + 25));
                        graphics.DrawLine(pen, startPoint, endPoint);
                    }
                }
            }

            return image;
        }
        public Form1()
        {
            InitializeComponent();
            captchaTimer = new Timer();
            captchaTimer.Interval = 15000;
            captchaTimer.Tick += new EventHandler(captchaTimer_Tick);
            captchaTimer.Start();
            GenerateAndSetCaptcha();
        }

        private void GenerateAndSetCaptcha()
        {
            expectedCaptcha = GenerateCaptcha();
            captchaLabel.Text = "";
            captchaLabel.Image = GenerateCaptchaImage(expectedCaptcha);
        }

        private void captchaTimer_Tick(object sender, EventArgs e)
        {
            GenerateAndSetCaptcha();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (ValidateCredentials(username, password))
            {
                MessageBox.Show("Авторизация успешна!");
                Close();
            }
            else
            {
                attempts++;

                if (attempts == 3)
                {
                    captchaLabel.Visible = true;
                    captchaTextBox.Visible = true;
                    loginButton.Enabled = false;
                }

                MessageBox.Show("Неверные логин или пароль!");
            }
        }

        private void captchaTextBox_TextChanged(object sender, EventArgs e)
        {
            string enteredCaptcha = captchaTextBox.Text;

            if (enteredCaptcha == expectedCaptcha)
            {
                MessageBox.Show("Успешный ввод капчи!");
                loginButton.Enabled = true;
            }
        }
    }
}
