﻿namespace NoteApp.Repository.Entities
{
    public class Result
    {    
        public bool IsSuccess { get; }
        public string Message { get; }

        public Result(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}

