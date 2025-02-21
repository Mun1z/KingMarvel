﻿namespace KingMarvel.Application.ViewModels.Response
{
    [Serializable]
    public class BaseResponseViewModel : IViewModel
    {
        public bool Success { get; set; }
        public object Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
