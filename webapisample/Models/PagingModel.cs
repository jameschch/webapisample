using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class PagingModel
    {

        private int _page = 1;
        private int _pageSize;

        public PagingModel()
        {
            _pageSize = MaximumPageSize;
        }

        protected virtual int MaximumPageSize { get { return 1000; } }

        [Display(Name = "PagingModel_Page")]
        public int Page
        {
            get
            {
                return _page;
            }
            set
            {
                SetPage(value);
            }
        }

        [Display(Name = "PagingModel_PageSize")]
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                SetPageSize(value);
            }
        }

        [Display(Name = "PagingModel_Descending")]
        public bool Descending { get; set; }

        private void SetPageSize(int value)
        {
            if (value > MaximumPageSize || value == 0) { value = MaximumPageSize; }
            _pageSize = value;
        }

        private void SetPage(int value)
        {
            if (value < 1) { value = 1; }
            _page = value;
        }

    }
}