CREATE VIEW hrm.job_info
AS
SELECT     hrm.job.job_id, hrm.job.node_id, hrm.job.job_title, hrm.job.job_summary, hrm.organization.node_name
FROM         hrm.job INNER JOIN
                      hrm.organization ON hrm.job.node_id = hrm.organization.node_id