﻿using System.Web;
using System.Web.Mvc;

namespace MessageCenter.Service.Web
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
