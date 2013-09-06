CREATE VIEW hrm.training_info
AS
SELECT     hrm.training_request.training_request_id, hrm.training_request.training_title, hrm.training_request.requested_date, hrm.training_request.requested_by, 
                      hrm.training.training_id, hrm.training.conducted_from, hrm.training.conducted_to, hrm.training.conducted_by, hrm.training.actual_cost
FROM         hrm.training LEFT OUTER JOIN
                      hrm.training_category LEFT OUTER JOIN
                      hrm.training_request ON hrm.training_category.training_category_id = hrm.training_request.training_category_id ON 
                      hrm.training.training_request_id = hrm.training_request.training_request_id