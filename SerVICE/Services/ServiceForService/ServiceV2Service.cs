namespace SerVICE.Services.ServiceForService
{
    public class ServiceV2Service : IService
    {

        private readonly DataContext _context;

        public ServiceV2Service(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> GetAllServices()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<Service?> GetSingleService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service is null) { return null; }
            return service;
        }

        public async Task<List<Service>> AddService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
            return await _context.Services.ToListAsync();
        }

        public async Task<Service> UpdateService(int id, Service request_service)
        {
            var existingService = await _context.Services.FindAsync(id);

            if (existingService is null)
                return null;

            existingService.Title = request_service.Title;
            existingService.Description = request_service.Description;
            existingService.Price = request_service.Price;
            existingService.Category.CategoryId = request_service.Category.CategoryId;

            await _context.SaveChangesAsync();
            return existingService;
        }

        public async Task<List<Service>> DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);

            if (service is null)
                return null;

            _context.Services.Remove(service);

            await _context.SaveChangesAsync();
            return await _context.Services.ToListAsync();
        }

        Task<List<Service>?> IService.UpdateService(int id, Service request_service)
        {
            throw new NotImplementedException();
        }
    }
}
