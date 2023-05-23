namespace Sporganize.DTO.Responses
{
    public class LoginResponse
    {
        public int? UserId { get; set; }
        public bool IsLoggedIn { get; set; }
        public string Message { get; set; }

        public LoginResponse(int userId)
        {
            if(userId == 0)
            {
                UserId = null;
                IsLoggedIn = false;
                Message = "username or password not matching!";
            } 
            else
            {
                UserId = userId;
                IsLoggedIn = true;
            }

        }

    }

}
