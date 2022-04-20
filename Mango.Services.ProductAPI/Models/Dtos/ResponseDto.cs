﻿namespace Mango.Services.ProductAPI.Models.Dtos
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public string? Result { get; set; }
        public string DisplayMessage { get; set; } = " ";
        public List<string>? ErrorMessages { get; set; }

    }
}
