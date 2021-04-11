using System.Collections.Generic;
using Application.Common.Dtos;

namespace Application.Common.ViewModels
{
    public class MessagesVm
    {
        public List<MessageDto> Messages { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}