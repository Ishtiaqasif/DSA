namespace Algorithms
{
    public class Sort
    {
        public void MergeSort(int[] numbers, int left, int right, SortOrder order = SortOrder.Ascending)
        {
            if (left >= right)
            {
                return;
            }

            int mid = (left + (right - left) / 2);

            MergeSort(numbers, left, mid);
            MergeSort(numbers, mid + 1, right);

            Merge(numbers, left, mid, right);
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (int x = 0; x < temp.Length; x++)
            {
                arr[left + x] = temp[x];
            }
        }
    }
}