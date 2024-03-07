using System;
using System.Collections.Generic;

namespace Lesson2_02._03._2024
{

    [Serializable]
    public class Users
    {
        public List<User> UserList { get; set; } = new List<User>();
    }
}
