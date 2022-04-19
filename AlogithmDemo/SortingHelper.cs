namespace AlogithmDemo
{
    public static class SortingHelper
    {
        public static List<int> SelectionSort(this List<int> originalList)
        {
            if (originalList == null || originalList.Count == 0)
            {
                return originalList;
            }

            List<int> sortedList = new List<int>(originalList.Count);
            while (originalList.Count > 0)
            {
                var nextSmallestIndex = originalList.GetSmallestItemIndex();

                sortedList.Add(originalList[nextSmallestIndex]);
                originalList.RemoveAt(nextSmallestIndex);
            }

            return sortedList;
        }

        private static int GetSmallestItemIndex(this List<int> originalList)
        {
            int smallestItem = originalList[0];
            int smallestItemIndex = 0;

            for (int i = 0; i < originalList.Count; i++)
            {
                if (originalList[i] < smallestItem)
                {
                    smallestItem = originalList[i];
                    smallestItemIndex = i;
                }
            }

            return smallestItemIndex;
        }
    }
}