using System.Collections.Generic;
using System.Linq;
using BorrowingApp_Assign1.Models;


namespace BorrowingApp_Assign1.Repositories
{
    public static class RequestRepository
    {
        private static List<Request> requests = new List<Request>();
        private static int nextId = 1;

        public static void AddRequest(Request request)
        {
            request.Id = nextId++;
            requests.Add(request);
        }

        public static List<Request> GetAllRequests()
        {
            return requests;
        }

        public static List<Request> GetAvailableRequests()
        {
            return requests.Where(r => r.Duration > 0).ToList();
        }
    }
}
