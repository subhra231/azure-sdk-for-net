// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class CommunicationJobRouterModelFactory
    {
        /// <summary> Initializes a new instance of RouterJobAssignment. </summary>
        /// <param name="assignmentId"> The Id of the job assignment. </param>
        /// <param name="workerId"> The Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <param name="completedAt"> The time the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> The time the job was marked as closed after being completed in UTC. </param>
        /// <returns> A new <see cref="Models.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(assignmentId, workerId, assignedAt, completedAt, closedAt);
        }

        /// <summary> Initializes a new instance of UnassignJobResult. </summary>
        /// <param name="jobId"> The Id of the job unassigned. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="Models.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new UnassignJobResult(jobId, unassignmentCount);
        }

        /// <summary> Initializes a new instance of AcceptJobOfferResult. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/>, <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        /// <returns> A new <see cref="Models.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return new AcceptJobOfferResult(assignmentId, jobId, workerId);
        }

        /// <summary> Initializes a new instance of RouterQueueStatistics. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimeMinutes"> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        /// <returns> A new <see cref="Models.RouterQueueStatistics"/> instance for mocking. </returns>
        public static RouterQueueStatistics RouterQueueStatistics(string queueId = null, int length = default, IReadOnlyDictionary<string, double> estimatedWaitTimeMinutes = null, double? longestJobWaitTimeMinutes = null)
        {
            estimatedWaitTimeMinutes ??= new Dictionary<string, double>();

            return new RouterQueueStatistics(queueId, length, estimatedWaitTimeMinutes, longestJobWaitTimeMinutes);
        }

        /// <summary> Initializes a new instance of RouterJobOffer. </summary>
        /// <param name="offerId"> The Id of the offer. </param>
        /// <param name="jobId"> The Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> The time the offer was created in UTC. </param>
        /// <param name="expiresAt"> The time that the offer will expire in UTC. </param>
        /// <returns> A new <see cref="Models.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(offerId, jobId, capacityCost, offeredAt, expiresAt);
        }

        /// <summary> Initializes a new instance of RouterWorkerAssignment. </summary>
        /// <param name="assignmentId"> The Id of the assignment. </param>
        /// <param name="jobId"> The Id of the Job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> or <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="Models.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt);
        }
    }
}
