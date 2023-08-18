﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIPI_GUIDE
{
    internal class Constants
    {
        /**
         * GENERAL
         */

        public static readonly string CONNECTION_STRING = "DataSource = unipiGuide.db;Version = 3";

        /** 
         * SQL STATEMENTS
         */

        // USER
        public static readonly string RETURN_USERNAME_FROM_ID_SQL = "SELECT username FROM user WHERE id=@id";
        public static readonly string RETURN_ID_FROM_USERNAME_SQL = "SELECT id FROM user WHERE username=@username";
        // EVENT
        public static readonly string RETURN_ALL_EVENTS_SQL = "SELECT * FROM event";
        public static readonly string RETURN_EVENT_DESCRIPTION_BASED_ON_DATE_SQL = "SELECT description FROM event WHERE year=@year AND month=@month AND day=@day";
        // COMMENT
        public static readonly string COUNT_ALL_COMMENTS_SQL = "SELECT count(*) FROM comment";
        public static readonly string RETURN_PAGE_OF_COMMENTS_SQL = "SELECT * FROM comment ORDER BY id DESC LIMIT @limit OFFSET @offset";
        public static readonly string RETURN_RATING_OF_COMMENT_SQL = "SELECT rating FROM comment WHERE id = @id";
        public static readonly string INSERT_NEW_COMMENT_SQL = "INSERT INTO comment (userId, body, rating) VALUES (@author, @body, 0)";
        public static readonly string UPDATE_COMMENT_RATING_SQL = "UPDATE comment SET rating = @value WHERE id = @commentId";
        // USER_RATING
        public static readonly string RETURN_ASSOCIATED_COMMENTS_OF_USER_SQL = "SELECT commentId, actionId  FROM user_rating WHERE userId = @userId";
        public static readonly string DELETE_USER_COMMENT_ASSOCIATION_SQL = "DELETE FROM user_rating WHERE userId = @userId AND commentId = @commentId";
        public static readonly string UPSERT_USER_COMMENT_ASSOCIATION_SQL = @"INSERT INTO user_rating (userId, commentId, actionId)  
                                                           VALUES(@userId, @commentId, @actionId)
                                                           ON CONFLICT(userId, commentId)
                                                           DO UPDATE SET actionId = @actionId";
        // RATING_ACTION
        public static readonly string RETURN_ACTION_OF_USER_ON_COMMENT_SQL = @"SELECT action 
                                                                               FROM rating_action AS ra
                                                                               INNER JOIN user_rating AS ur
                                                                                   ON ra.id = ur.actionID
                                                                               WHERE 
                                                                                   ur.userId=@userId 
                                                                                   AND ur.commentId=@commentId";

        public static readonly string SELECT_ACCOUNT_INFO_SQL = @"SELECT ui.firstname, ui.lastname, ui.email, d.name
                                FROM userInfo AS ui
                                INNER JOIN department AS d
                                    ON ui.departmentId = d.id
                                WHERE userId = @userId";
    }
}