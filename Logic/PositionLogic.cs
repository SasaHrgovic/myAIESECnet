﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PositionLogic
    {
        public List<Position> Get()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Position> positions = db.Positions.ToList();
                return positions;
            }
        }

        public void Add(Position newPosition)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Positions.Add(newPosition);
                db.SaveChanges();
            }
        }

        public void Update(Position positionToUpdate, Position newPosition)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Positions.Attach(positionToUpdate);
                positionToUpdate.Name = newPosition.Name;
                positionToUpdate.Description = newPosition.Description;
                db.SaveChanges();
            }
        }

        public void Delete(Position positionToUpdate)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Positions.Attach(positionToUpdate);
                db.Positions.Remove(positionToUpdate);
                db.SaveChanges();
            }
        }
    }
}
