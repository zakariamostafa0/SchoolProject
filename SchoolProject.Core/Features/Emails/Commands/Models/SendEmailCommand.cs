﻿namespace SchoolProject.Core.Features.Emails.Commands.Models
{
    public class SendEmailCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
        public string Message { get; set; }
        public string? Reason { get; set; }

    }
}
