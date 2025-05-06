namespace GawaPH.Models
{
    public class Bid
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string Proposal { get; set; }

        public DateTime BidDate { get; set; }

        public int JobPostId { get; set; }

        public int FreelancerId { get; set; }
    }
}
