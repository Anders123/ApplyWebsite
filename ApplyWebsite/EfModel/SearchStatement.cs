using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SearchStatement
    {
        public SearchStatement()
        {
            SearchStatementAttr = new HashSet<SearchStatementAttr>();
            SearchStatementCoreTitle = new HashSet<SearchStatementCoreTitle>();
            SearchStatementPost = new HashSet<SearchStatementPost>();
        }

        public int Id { get; set; }
        public string StatementName { get; set; }
        public string SearchStatement1 { get; set; }
        public string ExcludeStatement { get; set; }
        public string ReplaceStatement { get; set; }
        public int AccountId { get; set; }
        public bool SkipLongDesc { get; set; }

        public virtual ICollection<SearchStatementAttr> SearchStatementAttr { get; set; }
        public virtual ICollection<SearchStatementCoreTitle> SearchStatementCoreTitle { get; set; }
        public virtual ICollection<SearchStatementPost> SearchStatementPost { get; set; }
        public virtual Account Account { get; set; }
    }
}
