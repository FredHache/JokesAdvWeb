﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Joke : Types.IJokes
    {
        internal Joke() { }
        internal int _id;
        internal string _title;
        internal string _teaser;
        internal string _joke_text;
        internal DateTime _created_at;
        internal int _user_id;
        internal int _category_id;
        internal bool _featured;

        // JOKE ID
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        // TITLE
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        // TEASER
        public string teaser {
            get { return _teaser; }
            set { _teaser = value; }
        }

        // JOKE TEXT
        public string joke_text
        {
            get { return _joke_text; }
            set { _joke_text = value; }
        }

        // CREATION DATE
        public DateTime created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }

        // USER ID
        public int user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        // CATEGORY ID
        public int category_id
        {
            get { return _category_id; }
            set { _category_id = value; }
        }

        // FEATURED
        public bool featured
        {
            get { return _featured; }
            set { _featured = value; }
        }
    }
}
