namespace DDDSession.API.Model.Response
{
    public class ResponseMessage
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public ResponseMessage(int id, string message, bool issuccess) {
            Id = id;
            Message = message;
            IsSuccess = issuccess;
        }

        public static ResponseMessage ResponseMessages(int Id,string message, bool isSuccess) {
            return new(Id, message, isSuccess);
        }

    }
}
