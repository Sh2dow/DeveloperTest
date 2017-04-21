using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Facade
{
    public class Participant
    {
        #region Private Variables

        // Private variables.
        private M2.DeveloperTest.Context.DeveloperTest _context;

        #endregion

        #region Constructors

        public Participant(M2.DeveloperTest.Context.DeveloperTest context)
        {
            this._context = context;
        }

        #endregion

        #region Public Methods

        public void Add(M2.DeveloperTest.Entities.Participant participant)
        {
            // Remove all unsupported (e.g. emoji) characters from the participant name.
            participant.FirstName = this.CleanupParticipant(participant.FirstName);
            participant.LastName = this.CleanupParticipant(participant.LastName);

            this._context.Participants.Add(participant);
        }

        public List<M2.DeveloperTest.Entities.Participant> GetAll()
        {
            // Retrieve all the active participants.
            return (from participant in this._context.Participants
                    where participant.Active
                    select participant).ToList();
        }

        public M2.DeveloperTest.Entities.Participant GetParticipant(string participantEmail)
        {
            return (from participant in this._context.Participants
                    where participant.Email == participantEmail
                    select participant).SingleOrDefault();
        }

        #endregion

        #region Helper Methods

        private string CleanupParticipant(string participantName)
        {
            if (!string.IsNullOrWhiteSpace(participantName))
            {
                // Remove all characters that are not word or specified instances.
                participantName = Regex.Replace(participantName, @"[^\w\.'\- ]", string.Empty, RegexOptions.None);

                // Ensure that the name hasn't been completely cleared by the cleaning.
                if (string.IsNullOrWhiteSpace(participantName))
                    participantName = "Participant";
            }

            return participantName;
        }

        #endregion
    }
}
