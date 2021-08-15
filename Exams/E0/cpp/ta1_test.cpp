#define CATCH_CONFIG_MAIN
#include"catch.hpp"
#include"ta1.h"

TEST_CASE("ta1 solve test", "[ta1]") {
    REQUIRE(ta1::solve("R") ==  0);
    REQUIRE(ta1::solve("L") ==  0);
    REQUIRE(ta1::solve("LR") ==  0);
    REQUIRE(ta1::solve("RL") ==  1);
    REQUIRE(ta1::solve("RLLLL") ==  4);
    REQUIRE(ta1::solve("RRRRR") ==  0);
    REQUIRE(ta1::solve("LLLLL") ==  0);
    REQUIRE(ta1::solve("RLRRL") ==  3);
    REQUIRE(ta1::solve("LRLRLLLLLRLRLLLL")  == 11);
    REQUIRE(ta1::solve("RLLLR") ==  3 );
}