using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RotaryWebsite.CommonServices;
using RotaryWebsite.Models;

namespace RotaryWebsite.Controllers
{
    public class PhotoGalleryController : Controller
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;
        public PhotoGalleryController(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }
        public IActionResult Index()
        {
            return View(GetItemsAsync());
        }



        private List<AlbumModel> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    if (!string.IsNullOrEmpty(_myconfigs.Value.ChapterId))
                    {
                        var result = conn.QueryMultiple("GetAlbumWithPictures",
                            new { @chapterid = Convert.ToInt32(_myconfigs.Value.ChapterId) },
                                 commandType: CommandType.StoredProcedure);
                        var set1 = result.Read<AlbumModel>().ToList();
                        var set2 = result.Read<PicturesModel>().ToList();

                        foreach (var item in set1)
                        {
                            item.Pictures = set2.Where(x => x.albumid == item.albumId).ToList();
                            item.AllPictures = set2;
                        }

                        return set1;
                    }
                    else
                    {
                        var result = conn.QueryMultiple("GetAlbumWithPictures",
                            new { @chapterid = 0 },
                                     commandType: CommandType.StoredProcedure);
                        var set1 = result.Read<AlbumModel>().ToList();
                        var set2 = result.Read<PicturesModel>().ToList();

                        foreach (var item in set1)
                        {
                            item.Pictures = set2.Where(x => x.albumid == item.albumId).ToList();
                            item.AllPictures = set2;
                        }

                        return set1;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
