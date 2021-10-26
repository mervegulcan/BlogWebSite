using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface ICommentService
    {
        void AddComment(Comment comment);
        //void DeleteComment(Category category);
        //void UpdateCategory(Category category);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}
