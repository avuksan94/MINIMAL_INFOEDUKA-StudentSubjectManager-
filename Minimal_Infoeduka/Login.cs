using ProjectTest02;
using ProjectTest02.Models;
using ProjectTest02.Services;
using System.Drawing.Design;

namespace Minimal_Infoeduka
{
    public partial class LoginForm : Form
    {
        public UserService _userService;
        public ConnectionWatchDog _watchDog;
        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                _userService = new UserService();
                _watchDog= new ConnectionWatchDog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot find username or password in database(PLEASE CHECK YOUR PROVIDED INFORMATION)");
            }
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.Region = new Region(new Rectangle(0, 0, btnLogin.Width, btnLogin.Height));

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int borderRadius = 66;

            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(btnLogin.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(btnLogin.Width - borderRadius, btnLogin.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, btnLogin.Height - borderRadius, borderRadius, borderRadius, 90, 90);

            btnLogin.Region = new Region(path);

            //EXIT BUTTON 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.Region = new Region(new Rectangle(0, 0, btnLogin.Width, btnLogin.Height));

            btnExit.Region = new Region(path);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (_userService == null)
            {
                MessageBox.Show("UserService is not initialized.");
                return;
            }

            try
            {
                bool authenticate = _userService.AuthenticateUser(username, password);
                UserRole role = _userService.GetUserRole(username);

                if (authenticate && role == UserRole.Lecturer)
                {
                    LecturerDashboard lecturerDashboard = new LecturerDashboard(username);
                    _watchDog.CreateConnection(username);
                    lecturerDashboard.Show();

                }
                else if (authenticate && role == UserRole.Administrator)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    _watchDog.CreateConnection(username);
                    adminDashboard.Show();
                    
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot find username or password in database(PLEASE CHECK THE INFORMATION YOU HAVE PROVIDED)");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _watchDog.ClearFileContent();
            Close();
        }
    }
}