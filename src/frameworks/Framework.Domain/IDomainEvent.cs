namespace Framework.Domain;

public interface IDomainEvent<TKey>
{
	TKey Id { get; }

	System.DateTimeOffset PublishDateTime { get; }
}
