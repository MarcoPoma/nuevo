using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LoginSection
    {
        public TextBox emailTxtBox = new TextBox(By.ClassName("ycptinput"));
        
        public Button loginButton = new Button(By.Id("refreshbut"));

        public Button newemail = new Button(By.Id("newmail"));


       
        public TextBox pwdTxtBox = new TextBox(By.CssSelector("div.tooltip.click input#msgto"));
        
        public TextBox asuntoInput = new TextBox(By.CssSelector("div.inputsend input#msgsubject"));
      
        public TextBox cuerpoMensajeInput = new TextBox(By.CssSelector("div#msgbody"));
        
        public Button sendButton = new Button(By.CssSelector("button#msgsend"));
        

        public void Login(String user, String pwd,String asunto, String cuerpo) 
        { 
            emailTxtBox.SetText(user);
            pwdTxtBox.SetText(pwd);
            asuntoInput.SetText(asunto);
            cuerpoMensajeInput.SetText(cuerpo);
            loginButton.Click();
        }
    }
}
