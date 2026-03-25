cmake_minimum_required(VERSION 3.20)
project(DataStructuresCpp LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include(FetchContent)
FetchContent_Declare(
  googletest
  URL https://github.com/google/googletest/archive/refs/tags/v1.14.0.zip
)
FetchContent_MakeAvailable(googletest)

enable_testing()

add_executable(static_array_tests
  Tests/StaticArrayTests.cpp
)

add_executable(dynamic_array_tests
  Tests/DynamicArrayTests.cpp
)

target_include_directories(static_array_tests PRIVATE
  ${CMAKE_CURRENT_SOURCE_DIR}
)

target_include_directories(dynamic_array_tests PRIVATE
  ${CMAKE_CURRENT_SOURCE_DIR}
)

target_link_libraries(static_array_tests PRIVATE
  GTest::gtest_main
)

target_link_libraries(dynamic_array_tests PRIVATE
  GTest::gtest_main
)

include(GoogleTest)
gtest_discover_tests(static_array_tests)
gtest_discover_tests(dynamic_array_tests)