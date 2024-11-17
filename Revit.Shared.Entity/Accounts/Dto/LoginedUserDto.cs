using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Accounts.Dto
{
    public class LoginedUserDto : ObservableObject
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                SetProperty(ref _userName, value);
            }
        }


        private string _account;

        public string Account
        {
            get { return _account; }
            set
            {
                SetProperty(ref _account, value);
            }
        }

        private string _userPhoneNumber;

        public string UserPhoneNumber
        {
            get { return _userPhoneNumber; }
            set
            {
                SetProperty(ref _userPhoneNumber, value);
            }
        }

        /// <summary>
        /// 角色列表
        /// </summary>
        public string[] Roles { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Introduction { get; set; }


        public long UserId { get; set; }

    }
}
