﻿using LessonsAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgorithmExercises.Lessons
{
    public class Lesson8LeaderTests
    {
        /**
         * https://app.codility.com/programmers/lessons/8-leader/dominator/
         */
        [Theory]
        [InlineData(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }, new int[] { 0, 2, 4, 6, 7 })]
        [InlineData(new int[] { -2, -2, 3, -2, -2, -1, 3, -2 }, new int[] { 0, 1, 3, 4, 7 })]
        [InlineData(new int[] { 3, 4, 3, 2, 3, -1, 3, -2 }, new int[] { -1 })]
        [InlineData(new int[] { }, new int[] { -1 })]
        public void DominatorTest(int[] A, int[] possibleDominatorIndexes)
        {
            var dominatorIndex = new Lesson8Leader().Dominator(A);

            var assertIndex = Array.IndexOf(possibleDominatorIndexes, dominatorIndex);

            Assert.NotEqual(assertIndex, -1);
        }

        /**
         * https://app.codility.com/programmers/lessons/8-leader/equi_leader/
         */
        [Theory]
        [InlineData(new[] { 4, 3, 4, 4, 4, 2 }, 2)]
        [InlineData(new[] { 0, 0 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 0)]
        [InlineData(new[] { 4, 4, 2, 5, 3, 4, 4, 4 }, 3)]
        public void EquiLeaderTest(int[] A, int expectedEquiLeaders)
        {
            var equiLeaders = new Lesson8Leader().EquiLeader(A);

            Assert.Equal(expectedEquiLeaders, equiLeaders);
        }
    }
}
