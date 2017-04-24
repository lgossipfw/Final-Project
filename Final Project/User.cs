using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Lea Gossman
 * Project: Final Project
 * Date: 4/26/17
 * Description: A User object has fields for a username, password, and permission level.
 * The class handles some database operations like adding and updating a user. It also
 * can find a user and return its data.
 */
namespace Final_Project
{
    public class User
    {
        private string _username;       //Hold username
        private string _password;       //Hold password
        private string _permission;     //Hold permission level

        //Declare and instantiate user table adapter
        businessDataSetTableAdapters.UsersTableAdapter userAdapter = 
            new businessDataSetTableAdapters.UsersTableAdapter();

        /// <summary>
        /// Contructor for a User. Has three parameters.
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <param name="permission"><permission level</param>
        public User(string username, string password, string permission)
        {
            _username = username;
            _password = password;
            _permission = permission;
        }

        /// <summary>
        /// Empty contructor for a User
        /// </summary>
        public User()
        {

        }

        /// <summary>
        /// Get and set username property
        /// </summary>
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        /// <summary>
        /// Get and set password property
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        /// <summary>
        /// Get and set permission property
        /// </summary>
        public string Permission
        {
            get
            {
                return _permission;
            }
            set
            {
                _permission = value;
            }
        }

        /// <summary>
        /// Returns true if a user was successfully added to the database
        /// </summary>
        /// <returns></returns>
        public bool AddUserToDB()
        {
            try
            {
                userAdapter.Insert(_username,_password,_permission);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="permission"></param>
        /// <returns></returns>
        public bool UpdateUserInDB(int userID, string username, string password, string permission)
        {
            try
            {
                userAdapter.UpdateUser(username, password, permission, userID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a user
        /// </summary>
        /// <param name="userID">UserID to find user</param>
        /// <returns>Copy of user object</returns>
        public User GetUser(int userID)
        {
            User u = new Final_Project.User();
            //Declare user table
            businessDataSet.UsersDataTable userTable;
            //Fill table with user data
            userTable = userAdapter.GetData();
            //Declare user dataset row
            businessDataSet.UsersRow row;
            //Set row equal to user with matching user ID
            row = userTable.FindById(userID);
            u.Username = row.Username;
            u.Password = row.Password;
            u.Permission = row.Permission;

            return u;

        }
    }
}
