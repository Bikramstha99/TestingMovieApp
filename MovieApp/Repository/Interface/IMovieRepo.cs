﻿using MovieApp.Models.Domain;
using MovieApp.Models.Dto.Movie;

namespace MovieApp.Repository.Interface
{
    public interface IMovieRepo
    {
        bool AddMovies(AddMovie addmovie);
        bool UpdateMovies(UpdateMovie updatemovie);
        bool DeleteMovies(UpdateMovie deletemovie);
        UpdateMovie GetByID(int Id);
        List<UpdateMovie> GetAllMovies();
       
    }
}
