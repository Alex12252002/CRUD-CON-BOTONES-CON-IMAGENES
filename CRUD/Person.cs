﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    public class Person
    {

        
            [PrimaryKey, AutoIncrement]
            public int PersonID { get; set; }
            public string Name { get; set; }
        }
    }
