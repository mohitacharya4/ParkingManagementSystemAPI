﻿using Microsoft.EntityFrameworkCore;
using ParkingManagementSystemAPI.Data;
using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Services.Repositories
{
    public class ParkingAssignmentRepository : IParkingAssignmentRepository
    {
        private readonly ParkingContext _context;

        public ParkingAssignmentRepository(ParkingContext context)
        {
            _context = context;
        }

        public async Task<List<ParkingAssignment>> GetAllAsync()
        {
            return await _context.ParkingAssignments.ToListAsync();
        }

        public async Task<ParkingAssignment> GetByIdAsync(int assignmentId)
        {
            return await _context.ParkingAssignments.FindAsync(assignmentId);
        }

        public async Task AddAsync(ParkingAssignment assignment)
        {
            await _context.ParkingAssignments.AddAsync(assignment);
        }

        public async Task UpdateAsync(ParkingAssignment assignment)
        {
            _context.ParkingAssignments.Update(assignment);
        }

        public async Task DeleteAsync(int assignmentId)
        {
            var assignment = await _context.ParkingAssignments.FindAsync(assignmentId);
            if (assignment != null)
            {
                _context.ParkingAssignments.Remove(assignment);
            }
        }
    }
}
