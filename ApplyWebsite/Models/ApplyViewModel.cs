using ApplyWebsite.EfModel;
using Interview = WebApiCommon.Interview;

namespace ApplyWebsite.Models
{
    /// <summary>
    /// User can apply directly on a single post or add posts to a briefcase before applying 
    /// for all the posts in the briefcase.
    /// </summary>
    public class ApplyViewModel
    {
        /// <summary>
        /// Before adding to a briefcase the user must be signed in.
        /// </summary>
        public SignedInPerson SignedInPerson { get; set; }

        /// <summary>
        /// Single post to apply for.
        /// </summary>
        public Post Post { get; set; }

        /// <summary>
        /// The briefcase id with posts to apply for and used in the interview.
        /// </summary>
        public int BriefcaseId { get; set; }
    
        /// <summary>
        /// Questions for the interview.
        /// </summary>
        public Interview Interview { get; set; }

        /// <summary>
        /// Steps in the wizard
        /// </summary>
        public int CurrentStep { get; set; } = 1;
        public bool CanGoBack => (CurrentStep > 1);
        public bool CanGoForward => (CurrentStep < Interview?.Questions?.Count);

    }
}
