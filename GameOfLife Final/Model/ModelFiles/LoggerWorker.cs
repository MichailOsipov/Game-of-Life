﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelFiles
{
	public class LoggerWorker
	{
		private readonly Logger logger;
		public LoggerWorker()
		{
			logger = LogManager.GetCurrentClassLogger();
		}
		public void Log(string message)
		{
			logger.Info(message);
		}
	}
}
