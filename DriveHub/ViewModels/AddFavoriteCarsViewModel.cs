using System;
using System.ComponentModel.DataAnnotations;

namespace DriveHub.ViewModels
{
    public class AddFavoriteCarsViewModel
    {
        [Required(ErrorMessage = "Поле ID избранного автомобиля обязательно для заполнения")]
        public int FavoriteID { get; set; }

        [Required(ErrorMessage = "Поле ID пользователя обязательно для заполнения")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Поле ID автомобиля обязательно для заполнения")]
        public int CarID { get; set; }

        [Required(ErrorMessage = "Поле Дата добавления обязательно для заполнения")]
        public DateTime DateAdded { get; set; }
    }
}
