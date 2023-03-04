namespace Algorithms
{
    public class Sort
    {
        public void MergeSort(int[] numbers, int left, int right, SortOrder order = SortOrder.Ascending )
        {
            if(left >= right)
            {
                return;
            }

            int mid = (left + (right - right) / 2);

            MergeSort(numbers, left, mid, order );
            MergeSort(numbers, mid + 1, right, order );

            Merge(numbers, left, mid, right);
        }

        private void Merge(int[] numbers, int left, int mid, int right)
        {
            throw new NotImplementedException();
        }
    }
}