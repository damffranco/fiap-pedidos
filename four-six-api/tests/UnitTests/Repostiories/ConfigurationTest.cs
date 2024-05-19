﻿using FourSix.Controllers.Gateways.Configurations;
using FourSix.Controllers.Gateways.DataAccess;

namespace UnitTests.Repostiories
{
    public class ConfigurationTest
    {
        [Fact]
        public void PedidoConfiguration_DeveRetornarArgumentNullException_QuandoBuilderIsNull()
        {
            // Arrange
            var pedidoConfiguration = new PedidoConfiguration();

            // Act
            Action act = () => pedidoConfiguration.Configure(null);

            // Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void PedidoCheckoutConfiguration_DeveRetornarArgumentNullException_QuandoBuilderIsNull()
        {
            // Arrange
            var pedidoCheckoutConfiguration = new PedidoCheckoutConfiguration();

            // Act
            Action act = () => pedidoCheckoutConfiguration.Configure(null);

            // Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void PedidoItemConfiguration_DeveRetornarArgumentNullException_QuandoBuilderIsNull()
        {
            // Arrange
            var pedidoItemConfiguration = new PedidoItemConfiguration();

            // Act
            Action act = () => pedidoItemConfiguration.Configure(null);

            // Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void StatusPedidoConfiguration_DeveRetornarArgumentNullException_QuandoBuilderIsNull()
        {
            // Arrange
            var statusPedidoConfiguration = new StatusPedidoConfiguration();

            // Act
            Action act = () => statusPedidoConfiguration.Configure(null);

            // Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void Seed_DeveRetornarArgumentNullException_QuandoBuilderIsNull()
        {
            // Arrange


            // Act
            Action act = () => SeedData.Seed(null);

            // Assert
            Assert.Throws<ArgumentNullException>(act);
        }
    }
}
