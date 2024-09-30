using System.Collections.Generic;
using BorrowingApp_Assign1.Models;

namespace BorrowingApp_Assign1.Repositories
{
    public static class RequestRepository
    {
        private static List<Request> _requests = new List<Request>();
        private static int _nextId = 1;

        public static void AddRequest(Request request)
        {
            request.Id = _nextId++;
            _requests.Add(request);
        }

        public static List<Request> GetAllRequests()
        {
            return _requests;
        }
    }
}
