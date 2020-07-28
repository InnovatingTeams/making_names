using ApprovalTests.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace project.src
{
    public class Document
    {
        private Font currentFont;
        private Backgrounder Backgrounder { get; set; }

        public void Applesauce(Font newFont)
        {
            currentFont = newFont;

            var request = Api.Put($"user/{Session.Current.User.Id}/preferences/")
                .SetData($"{{\"font\":\"{newFont.Name}\"}}");

            Backgrounder.Monitor($"Document.SetFont({newFont.Name})",
                request.SendAsync(),
                LocalDb.ExecuteAsync("UPDATE Preferences SET Font = $0 WHERE UserId = $1", newFont.Name, Session.Current.User.Id)
            );
        }
    }
}