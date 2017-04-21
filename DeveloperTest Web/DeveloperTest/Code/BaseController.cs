using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeveloperTest.Code
{
    public class BaseController : Controller
    {
        #region Private Variables

        // Private variables.
        private M2.DeveloperTest.Context.DeveloperTest _developerTestContext = default(M2.DeveloperTest.Context.DeveloperTest);
        private M2.DeveloperTest.Facade.Participant _participantFacade = default(M2.DeveloperTest.Facade.Participant);

        #endregion

        #region Protected Properties

        protected M2.DeveloperTest.Context.DeveloperTest DeveloperTestContext
        {
            get
            {
                return this._developerTestContext ?? (this._developerTestContext = new M2.DeveloperTest.Context.DeveloperTest(string.IsNullOrWhiteSpace(User.Identity.Name) ? M2.DeveloperTest.Constants.Constant.SystemEmail : User.Identity.Name));
            }
        }

        protected M2.DeveloperTest.Facade.Participant ParticipantFacade
        {
            get
            {
                return this._participantFacade ?? (this._participantFacade = new M2.DeveloperTest.Facade.Participant(this.DeveloperTestContext));
            }
        }

        #endregion

        #region Protected Methods

        protected override void Dispose(bool disposing)
        {
            // Call our base class Dispose method.
            base.Dispose(disposing);

            // If we are Disposing and we have a developer test context than Dispose of our developer test context. 
            if ((disposing) && this._developerTestContext != default(M2.DeveloperTest.Context.DeveloperTest))
            {
                this._developerTestContext.Dispose();
            }
        }

        #endregion
    }
}