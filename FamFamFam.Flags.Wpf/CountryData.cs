/*
 * Created by Drew Noakes
 * 17 April 2017
 * https://drewnoakes.com
 */

using System.Collections.Generic;

namespace FamFamFam.Flags.Wpf
{
    /// <summary>
    /// Reference data and utility methods for working with country data such as ISO 3166-1 alpha-2 codes and names (in English).
    /// </summary>
    public static class CountryData
    {
        private const string AllCountryIdsString
            = "ad,ae,af,ag,ai,al,am,an,ao,ar,as,at,au,aw,ax,az,ba,bb,bd,be,bf,bg,bh,bi,bj,bm,bn,bo,br,bs,bt,bv,bw,by,"
              + "bz,ca,catalonia,cc,cd,cf,cg,ch,ci,ck,cl,cm,cn,co,cr,cs,cu,cv,cx,cy,cz,de,dj,dk,dm,do,dz,ec,ee,eg,eh,en,"
              + "er,es,et,eu,fi,fj,fk,fm,fo,fr,ga,gb,gd,ge,gf,gg,gh,gi,gl,gm,gn,gp,gq,gr,gs,gt,gu,gw,gy,hk,hm,hn,hr,ht,hu,"
              + "id,ie,il,in,io,iq,ir,is,it,jm,jo,jp,ke,kg,kh,ki,km,kn,kp,kr,kw,ky,kz,la,lb,lc,li,lk,lr,ls,lt,lu,lv,ly,ma,"
              + "mc,md,me,mg,mh,mk,ml,mm,mn,mo,mp,mq,mr,ms,mt,mu,mv,mw,mx,my,mz,na,nc,ne,nf,ng,ni,nl,no,np,nr,nu,nz,om,pa,"
              + "pe,pf,pg,ph,pk,pl,pm,pn,pr,ps,pt,pw,py,qa,re,ro,rs,ru,rw,sa,sb,sc,scotland,sd,se,sg,sh,si,sj,sk,sl,sm,sn,"
              + "so,sr,st,sv,sy,sz,tc,td,tf,tg,th,tj,tk,tl,tm,tn,to,tr,tt,tv,tw,tz,ua,ug,um,us,uy,uz,va,vc,ve,vg,vi,vn,vu,"
              + "wales,wf,ws,ye,yt,za,zm,zw";

        /// <summary>
        /// Returns an enumerable set of country ids supported by this set of flags.
        /// </summary>
        public static IEnumerable<string> AllCountryIds
        {
            get
            {
                int startIndex = 0;
                int endIndex;
                while ((endIndex = AllCountryIdsString.IndexOf(',', startIndex)) != -1)
                {
                    yield return AllCountryIdsString.Substring(startIndex, endIndex - startIndex);
                    startIndex = endIndex + 1;
                }
                yield return AllCountryIdsString.Substring(startIndex, AllCountryIdsString.Length - startIndex);
            }
        }
    }
}