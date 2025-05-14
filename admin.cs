using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Google.Cloud.Firestore;

namespace fse_project
{
    public partial class admin : Form
    {
        private FirestoreDb db;

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            InitializeFirebase();
            InitializeDataGridView();
            LoadUsersAsync(); // Load users when form loads
        }

        private void InitializeFirebase()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "naflqueue-firebase-adminsdk-fbsvc-dffb95e1ca.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

                db = FirestoreDb.Create("naflqueue"); // Replace with your Firebase project ID
                Console.WriteLine("Connected to Firestore");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize Firestore: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridView()
        {
            dgvUsers.ColumnCount = 3; // Define columns: Username, Email
            dgvUsers.Columns[0].Name = "User ID";
            dgvUsers.Columns[1].Name = "Username";
            dgvUsers.Columns[2].Name = "Email";

            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Width = 200;
            dgvUsers.Columns[2].Width = 200;

            dgvUsers.RowHeadersVisible = false; // ✅ Hides the unnecessary row headers
        }

        private async void LoadUsersAsync()
        {
            dgvUsers.Rows.Clear(); // Clear existing rows

            try
            {
                CollectionReference usersRef = db.Collection("users");
                QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

                foreach (DocumentSnapshot doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string id = doc.Id;
                        string username = doc.ContainsField("Username") ? doc.GetValue<string>("Username") : "N/A";
                        string email = doc.ContainsField("Email") ? doc.GetValue<string>("Email") : "N/A";

                        //dgvUsers.Rows.Add( username, email);
                        dgvUsers.Rows.Add(id, username, email); // ✅ Add user ID as first column
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0) // Check if any cell is selected
            {
                int rowIndex = dgvUsers.SelectedCells[0].RowIndex; // Get selected row index
                DataGridViewRow selectedRow = dgvUsers.Rows[rowIndex]; // Get the full row

                if (selectedRow.Cells[0].Value != null) // Ensure ID exists
                {
                    string userId = selectedRow.Cells[0].Value.ToString(); // Get User ID

                    try
                    {
                        DocumentReference docRef = db.Collection("users").Document(userId);
                        await docRef.DeleteAsync();
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsersAsync(); // Refresh user list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected user does not have a valid ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
