// <copyright file="ScoreHistoryTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using System;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="ScoreHistoryTest" />.
    /// </summary>
    internal class ScoreHistoryTest
    {
        /// <summary>
        /// The TestScoreHistoryWithValidValues1.
        /// </summary>
        [Test]
        public void TestScoreHistoryWithValidValues1()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            };

            ScoreHistoryValidator validator = new ScoreHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestScoreHistoryWithValidValues2.
        /// </summary>
        [Test]
        public void TestScoreHistoryWithValidValues2()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                Score = 56
            };

            ScoreHistoryValidator validator = new ScoreHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestScoreHistoryWithValidValues3.
        /// </summary>
        [Test]
        public void TestScoreHistoryWithValidValues3()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
            };

            ScoreHistoryValidator validator = new ScoreHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestScoreHistoryWithValidValues4.
        /// </summary>
        [Test]
        public void TestScoreHistoryWithValidValues4()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                Score = 56
            };

            ScoreHistoryValidator validator = new ScoreHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestScoreHistoryProperty1.
        /// </summary>
        [Test]
        public void TestScoreHistoryProperty1()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            };

            Assert.AreEqual(test.IdScoreHistory, 1);
            Assert.AreEqual(test.PersonId, 2);
            Assert.AreEqual(test.Score, 56);
        }

        /// <summary>
        /// The TestScoreHistoryProperty2.
        /// </summary>
        [Test]
        public void TestScoreHistoryProperty2()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            };

            Assert.AreNotEqual(test.IdScoreHistory, 45);
            Assert.AreNotEqual(test.PersonId, 4);
            Assert.AreNotEqual(test.Score, 86);
        }
    }
}
