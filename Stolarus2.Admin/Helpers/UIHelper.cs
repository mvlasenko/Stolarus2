﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Helpers
{
    public static class UIHelper
    {

        public static List<Slider> GetSliders()
        {
            ISlidersRepository repository = DependencyResolver.Current.GetService<ISlidersRepository>();
            return repository.GetList().ToList();
        }
        public static List<ProductCategory> GetProductCategories()
        {
            IProductCategoriesRepository repository = DependencyResolver.Current.GetService<IProductCategoriesRepository>();
            return repository.GetList().ToList();
        }
        public static List<Product> GetProducts()
        {
            IProductsRepository repository = DependencyResolver.Current.GetService<IProductsRepository>();
            return repository.GetList().ToList();
        }
        public static List<PortfolioType> GetPortfolioTypes()
        {
            IPortfolioTypesRepository repository = DependencyResolver.Current.GetService<IPortfolioTypesRepository>();
            return repository.GetList().ToList();
        }
        public static List<Portfolio> GetPortfolios()
        {
            IPortfoliosRepository repository = DependencyResolver.Current.GetService<IPortfoliosRepository>();
            return repository.GetList().ToList();
        }
        public static List<PortfolioDetail> GetPortfolioDetails()
        {
            IPortfolioDetailsRepository repository = DependencyResolver.Current.GetService<IPortfolioDetailsRepository>();
            return repository.GetList().ToList();
        }
        public static List<Article> GetArticle()
        {
            IArticleRepository repository = DependencyResolver.Current.GetService<IArticleRepository>();
            return repository.GetList().ToList();
        }
        public static List<Quote> GetQuotes()
        {
            IQuotesRepository repository = DependencyResolver.Current.GetService<IQuotesRepository>();
            return repository.GetList().ToList();
        }
        public static List<Contact> GetContacts()
        {
            IContactsRepository repository = DependencyResolver.Current.GetService<IContactsRepository>();
            return repository.GetList().ToList();
        }
        public static List<Certificate> GetCertificates()
        {
            ICertificatesRepository repository = DependencyResolver.Current.GetService<ICertificatesRepository>();
            return repository.GetList().ToList();
        }

        public static MvcHtmlString Cut(this MvcHtmlString str, int maxLength)
        {
            return new MvcHtmlString(str.ToString().Cut(maxLength));
        }

        public static MvcHtmlString StripTags(this MvcHtmlString str)
        {
            return new MvcHtmlString(str.ToString().StripTags());
        }

        public static string GetDateFormat()
        {
            return "DD/MM/YYYY";
        }

        public static string GetDateTimeFormat()
        {
            return "DD/MM/YYYY HH:mm";
        }

        public static string Cut(this string str, int maxLength)
        {
            if (maxLength < 5)
                maxLength = 5;

            if (str.Length > maxLength)
            {
                return str.Substring(0, maxLength - 2) + "..";

            }
            return str;
        }

        public static string StripTags(this string str)
        {
            str = HttpUtility.HtmlDecode(str);
            str = HttpUtility.HtmlDecode(str);
            return Regex.Replace(str, "<.*?>", string.Empty);
        }

        public static string StripSpaces(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return Regex.Replace(str, @"\s+", "");
        }

        public static string StripDoubleSpaces(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return Regex.Replace(str, @"\s+", " ");
        }

        public static string HtmlToText(this string str)
        {
            str = HttpUtility.HtmlDecode(str);
            str = str.StripDoubleSpaces();
            str = str.Replace("</p>", "\r\n");
            str = Regex.Replace(str, "<br.*>", "\r\n");
            return str.StripTags();
        }

        public static int ToInt(this int? value, int defaultInt)
        {
            if (value == null)
                return defaultInt;
            return value.Value;
        }

        public static int ToInt(this string value, int defaultInt)
        {
            if (string.IsNullOrEmpty(value))
                return defaultInt;

            int res;

            if (int.TryParse(value, out res))
                return res;

            return defaultInt;
        }

        public static decimal ToDecimal(this decimal? value, decimal defaultDecimal)
        {
            if (value == null)
                return defaultDecimal;
            return value.Value;
        }

        public static string ToDuration(DateTime? start, DateTime? end)
        {
            if (start == null)
                return string.Empty;

            if (end == null)
                return string.Format("{0} {1}, {2}", start.Value.Day, CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(start.Value.Month), start.Value.Year);

            if (start.Value.Month != end.Value.Month)
                return string.Format("{0} {1} - {2} {3}, {4}", start.Value.Day, CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(start.Value.Month), end.Value.Day, CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(end.Value.Month), end.Value.Year);

            if (end.Value.Day - start.Value.Day > 3)
                return string.Format("{0} - {1} {2}, {3}", start.Value.Day, end.Value.Day, CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(end.Value.Month), end.Value.Year);

            List<int> days = new List<int>();
            for (int i = start.Value.Day; i <= end.Value.Day; i++)
            {
                days.Add(i);
            }

            return string.Format("{0} {1}, {2}", string.Join(" ", days), CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(end.Value.Month), end.Value.Year);
        }

    }
}