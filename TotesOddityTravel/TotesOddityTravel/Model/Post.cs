using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TotesOddityTravel.Model
{
    public class Post
    {
        #region Properties

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(300)]
        public string Experience { get; set; }

        #endregion
    }
}
