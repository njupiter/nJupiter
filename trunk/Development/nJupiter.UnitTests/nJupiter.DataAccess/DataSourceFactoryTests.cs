﻿using System;
using System.Data.Common;

using FakeItEasy;

using nJupiter.DataAccess;

using NUnit.Framework;

namespace nJupiter.UnitTests.DataAccess {

	[TestFixture]
	public class DataSourceFactoryTests {

		[Test]
		public void Create_CreatingExistingProvider_ReturnsDataSource() {
			var providerFactory = A.Fake<DbProviderFactory>();
			var dataSource = DataSourceFactory.Create(providerFactory);
			Assert.IsNotNull(dataSource);
		}

		[Test]
		public void Create_CreatingNonExistingProvider_TrowsArgumentException() {
			Assert.Throws<ArgumentException>(() => DataSourceFactory.Create("Non existing provider for nJupiter.UnitTests.DataAccess.DataSourceFactoryTests"));
		}

	}
}
