using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class SortTests
    {
        private readonly Sort _sort;
        public SortTests()
        {
            _sort = new Sort();
        }
        [TestMethod]
        public void MergeSort_RandomOrderedArray_ShouldBeSortedInAsyncOrder()
        {
            int[] ints = { 8, 7, 4, 2, 6, 5, 3, 1 };
            
            _sort.MergeSort(ints, 0, ints.Length - 1);

            Assert.AreEqual(ints[0], 1);
            Assert.AreEqual(ints[ints.Length - 1], 8);
            Assert.AreEqual(ints.Length, 8);
        }
        [TestMethod]
        public void MergeSort_SortRandomIntArray_ReturnsSortedArray()
        {
            // Arrange
            int[] unsortedArray = { 3, 7, 1, 8, 5, 2, 9, 4, 6 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            _sort.MergeSort(unsortedArray, 0, unsortedArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, unsortedArray);
        }

        [TestMethod]
        public void MergeSort_SortEmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] unsortedArray = new int[0];
            int[] expectedSortedArray = new int[0];

            // Act
            _sort.MergeSort(unsortedArray, 0, unsortedArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, unsortedArray);
        }

        [TestMethod]
        public void MergeSort_SortAlreadySortedArray_ReturnsSameArray()
        {
            // Arrange
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5 };

            // Act
           _sort.MergeSort(sortedArray, 0, sortedArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, sortedArray);
        }

        [TestMethod]
        public void MergeSort_SortLargeRandomIntArray_ReturnsSortedArray()
        {
            // Arrange
            int[] unsortedArray = new int[10000];
            Random rand = new Random();

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rand.Next(0, 10000);
            }

            int[] expectedSortedArray = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, expectedSortedArray, unsortedArray.Length);
            Array.Sort(expectedSortedArray);

            // Act
            _sort.MergeSort(unsortedArray, 0, unsortedArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, unsortedArray);
        }

        [TestMethod]
        public void MergeSort_SortAlreadyReverseSortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] reverseSortedArray = { 5, 4, 3, 2, 1 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5 };

            // Act
            _sort.MergeSort(reverseSortedArray, 0, reverseSortedArray.Length -1);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, reverseSortedArray);
        }

        [TestMethod]
        public void MergeSort_SortArrayWithDuplicateValues_ReturnsSortedArray()
        {
            // Arrange
            int[] arrayWithDuplicates = { 2, 3, 1, 2, 4, 3 };
            int[] expectedSortedArray = { 1, 2, 2, 3, 3, 4 };

            // Act
            _sort.MergeSort(arrayWithDuplicates, 0, arrayWithDuplicates.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, arrayWithDuplicates);
        }
    }
}