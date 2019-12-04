using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoldReviews.Web.Models;

namespace GoldReviews.Web
{
    public partial class _Default : Page
    {
        private ReviewsModel _model;

        public _Default()
        {
            _model = new ReviewsModel();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}