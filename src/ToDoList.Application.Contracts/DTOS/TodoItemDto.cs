﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DTOS
{
    public class TodoItemDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
