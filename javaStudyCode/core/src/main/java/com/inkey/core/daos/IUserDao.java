package com.inkey.core.daos;

import com.inkey.core.pojo.SyUser;

public interface IUserDao {
	SyUser GetUserById(int userId);
}