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

        public async Task<List<Service>?> UpdateService(int id, Service request_service)
        {
            var service = await _context.Services.FindAsync(id);
            if (service is null) { return null;}

            service.Title = request_service.Title;
            service.Description = request_service.Description;
            service.Price = request_service.Price;
            service.Category= request_service.Category;

            await _context.SaveChangesAsync();

            return await _context.Services.ToListAsync();
        }

        public async Task<List<Service>?> DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);

            if (service is null)
                return null;

            _context.Services.Remove(service);

            await _context.SaveChangesAsync();
            return await _context.Services.ToListAsync();
        }

    }
}
