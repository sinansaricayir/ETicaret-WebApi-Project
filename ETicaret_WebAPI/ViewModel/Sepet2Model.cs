using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret_WebAPI.ViewModel
{
    public class Sepet2Model
    {
        public int SepetId { get; set; }
        public int SepetUrunId { get; set; }
        public UrunModel urunBilgi { get; set; }
        public int SepetUyeId { get; set; }
        public MusteriModel musteriBilgi { get; set; }
        public int SepetOnay { get; set; }
    }
}