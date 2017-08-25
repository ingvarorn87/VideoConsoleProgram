using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoConsoleProgram;

namespace VideoConsoleDAL.Repositories
{
    class VideoRepositoryFakeDB : iVideoRepository
    {
        #region FakeDB

        private static int id = 1;
        private static List<Video> videos = new List<Video>();

        #endregion

        public Video Create(Video vid)
        {
                Video newVid;
                videos.Add(newVid = new Video()
                {
                    VideoName = vid.VideoName,
                    Genre = vid.Genre,
                    Year = vid.Year,
                    Id = id++

                });
                return newVid;
            }

            public Video Delete(int Id)
            {
                var vid = Get(Id);
                videos.Remove(vid);
                return vid;
            }

            public Video Get(int Id)
            {
                return videos.FirstOrDefault(x => x.Id == Id);
            }

            public List<Video> GetAll()
            {
                return new List<Video>(videos);
            }
        }
    }

