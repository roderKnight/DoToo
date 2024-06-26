﻿using DoToo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoToo.Repositories
{
    public interface ITodoItemRepository
    {
        event EventHandler<TodoItem> OnItemAdded;
        event EventHandler<TodoItem> OnItemUpdated;
        event EventHandler<TodoItem> OnItemDeleted;

        Task<List<TodoItem>> GetItems();
        Task AddItem(TodoItem item);
        Task UpdateItem(TodoItem item);
        Task AddOrUpdate(TodoItem item);
        Task<bool> DeleteItem(int id);
    }
}
