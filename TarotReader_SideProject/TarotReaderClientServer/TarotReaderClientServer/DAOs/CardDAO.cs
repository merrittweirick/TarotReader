using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TarotReaderServer.Models;

namespace TarotReaderServer.DAOs
{
    public class CardDAO : ICardDAO
    {
        private readonly string connection;
        public CardDAO(string connectionstring)
        {
            this.connection = connectionstring;
        }

        public List<Card> BuildFullDeck()
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                List<Card> deck = new List<Card>();
                SqlCommand cmd = new SqlCommand("select id, name, arcana, " +
                    "as_advice, as_advice_rev, as_obstacle, as_obstacle_rev, as_situation, as_situation_rev  from Card;", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Card card = AssignCardProperties(reader);
                    deck.Add(card);
                }
                return deck;
            }
        }
        public List<Card> BuildDeckByArcana(string arcana)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                List<Card> deck = new List<Card>();
                SqlCommand cmd = new SqlCommand("select id, name, arcana, " +
                    "as_advice, as_advice_rev, as_obstacle, as_obstacle_rev, as_situation, as_situation_rev  from Card" +
                    "where arcana = @arcana;", conn);
                if (arcana.Contains("Major"))
                {
                    cmd.Parameters.AddWithValue("arcana", arcana);
                }
                else
                {
                    cmd.Parameters.AddWithValue("arcana", arcana);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Card card = AssignCardProperties(reader);
                    deck.Add(card);
                }
                return deck;
            }
        }
        public Card GetCardById(int id)
        {
            Card card = new Card();
            using(SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("select id, name, arcana, " +
                    "as_advice, as_advice_rev, as_obstacle, as_obstacle_rev, as_situation, as_situation_rev  " +
                    "from Card where id = @id; ", conn);
                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    card= AssignCardProperties(reader);
                }
                return card;
            }
        }
        public Card GetCardByName(string name)
        {
            Card card = new Card();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("select id, name, arcana, " +
                    "as_advice, as_advice_rev, as_obstacle, as_obstacle_rev, as_situation, as_situation_rev  " +
                    "from Card where name = @name; ", conn);
                cmd.Parameters.AddWithValue("name", name);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    card = AssignCardProperties(reader);
                }
                return card;
            }
        }
        private Card AssignCardProperties (SqlDataReader reader)
        {
            Card card = new Card();

            card.CardId = Convert.ToInt32(reader["id"]);
            card.Name = Convert.ToString(reader["name"]);
            card.Arcana = Convert.ToString(reader["arcana"]);
            card.As_advice = Convert.ToString(reader["as_advice"]);
            card.As_advice_rev = Convert.ToString(reader["as_advice_rev"]);
            card.As_obstacle = Convert.ToString(reader["as_obstacle"]);
            card.As_obstacle_rev = Convert.ToString(reader["as_obstacle_rev"]);
            card.As_situation = Convert.ToString(reader["as_situation"]);
            card.As_situation_rev = Convert.ToString(reader["as_situation_rev"]);
            return card;
        }

    }
}
