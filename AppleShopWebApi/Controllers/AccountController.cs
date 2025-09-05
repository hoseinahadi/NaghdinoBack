using System;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using BusinessServiceContract.Services;
using DomainModel.DTO.User;
using Framework.Password;
using Framework.Token;
using Intuit.Ipp.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AppleShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("CompanyA")]
    public class AccountController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IGenerateNewToken _generateNewToken;
        private readonly IAccountApplication _accountApplication;

        public AccountController(IUserBusiness userBusiness, IPasswordHasher passwordHasher, IGenerateNewToken generateNewToken, IAccountApplication accountApplication)
        {
            _userBusiness = userBusiness;
            _passwordHasher = passwordHasher;
            _generateNewToken = generateNewToken;
            _accountApplication = accountApplication;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(Login log)
        {
            
            var user = _userBusiness.GetUserByUserName(log.Username);
            if (user == null)
            {
                return NotFound("UserName Not Exist");
            }
            var pp =_accountApplication.Login(log);

            if (pp.Success==true)
            {
                return Ok(pp);
            }

            return BadRequest(pp);
            
            
        }

        [HttpPost("SmsSend")]
        public async Task<IActionResult> Login(string number)
        {

            //var user = _accountApplication.GetUserWithPhone(number);
            //if (user == null)
            //{
            //    return NotFound("UserName Not Exist");
            //}
            //else
            //{
                try
                {
                var random = new Random();
                var Code = random.Next(1000,9999).ToString();
                var client = new HttpClient();
                    client.DefaultRequestHeaders.Add("ApiKey", "974630c4b09e7229b5864f60a37bbf07f05aa2b4eadef8de879b67163f875b94iWDhfv23LmtV4zzL");
                    var request = new HttpRequestMessage(HttpMethod.Post, "https://gateway.ghasedak.me/rest/api/v1/WebService/SendOtpSMS");

                    var smsRequest = new SmsRequest
                    {
                        SendDate = "2024-07-04T07:41:15.992Z",
                        Receptors = new[]
                        {








                            new Receptor
                            {
                                Mobile = number,
                                ClientReferenceId = "1"
                            }
                        },
                        TemplateName = "Ghasedak",
                        Inputs = new[]
                        {
                            new Input
                            {
                                Param = "Code",
                                Value = Code
                            }
                        },
                        Udh = true,
                        isVoice = false
                    };

                    var json = JsonConvert.SerializeObject(smsRequest);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    request.Content = content;

                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    var result = await response.Content.ReadAsStringAsync();
                    return Ok(result);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }

            //}

            

            
        }


        [HttpPost("SmsVerification")]
        public async Task<IActionResult> Login(string number,string Code)
        {

            try
            {

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest("LoginFailed");
            }



        }






        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
             _accountApplication.LogoutUser();
             return Ok();
        }
        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(Login log)
        {
            return Ok();
        }
        [HttpGet("GetCurrentUser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var result = _accountApplication.GetAccountInfo();
            string lang = Request.Cookies["CURRENTUSERK_EY"];
            if (result.Token == null)
            {
                return NotFound("No User Login");
            }
            return Ok(result);
        }























        public class Receptor
        {
            public string Mobile { get; set; }
            public string ClientReferenceId { get; set; }
        }

        public class Input
        {
            public string Param { get; set; }
            public string Value { get; set; }
        }

        public class SmsRequest
        {
            public string SendDate { get; set; }
            public Receptor[] Receptors { get; set; }
            public string TemplateName { get; set; }
            public Input[] Inputs { get; set; }
            public bool Udh { get; set; }
            public bool isVoice { get; set; }
        }

    }
}
